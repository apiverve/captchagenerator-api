declare module '@apiverve/captchagenerator' {
  export interface captchageneratorOptions {
    api_key: string;
    secure?: boolean;
  }

  /**
   * Describes fields the current plan does not unlock. Locked fields arrive as null
   * in `data`; `locked_fields` names them, using dot paths for nested fields.
   * Absent when the plan unlocks everything.
   */
  export interface PremiumInfo {
    message: string;
    upgrade_url: string;
    locked_fields: string[];
  }

  export interface captchageneratorResponse {
    status: string;
    error: string | null;
    data: CaptchaGeneratorData;
    code?: number;
    premium?: PremiumInfo;
  }


  interface CAPTCHAGeneratorData {
      id:          null | string;
      expires:     number | null;
      solution:    null | string;
      downloadURL: null | string;
  }

  export default class captchageneratorWrapper {
    constructor(options: captchageneratorOptions);

    execute(callback: (error: any, data: captchageneratorResponse | null) => void): Promise<captchageneratorResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: captchageneratorResponse | null) => void): Promise<captchageneratorResponse>;
    execute(query?: Record<string, any>): Promise<captchageneratorResponse>;
  }
}
